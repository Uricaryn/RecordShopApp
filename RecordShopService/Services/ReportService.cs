using System;
using System.Collections.Generic;
using System.Linq;
using RechordShopApp.Enum;
using RecordShopAppDAL.Interface;
using RecordShopService.DTOs;

namespace RecordShopService.Services
{
    public class ReportService
    {
        private readonly IAlbumRepo _albumRepo;

        public ReportService(IAlbumRepo albumRepo)
        {
            _albumRepo = albumRepo;
        }

        public IList<AlbumGetDto> GetAllAlbums()
        {
            try
            {
                return _albumRepo.GetAll()
                    .Select(a => new AlbumGetDto
                    {
                        Id = a.Id,
                        AlbumName = a.AlbumName,
                        Artist = a.Artist,
                        ReleaseDate = a.ReleaseDate,
                        Price = a.Price,
                        DisctountRate = a.DisctountRate,
                        Status = a.Status,
                        Genre = a.Genre
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred while retrieving all albums: " + ex.Message);
            }
        }

        public IList<AlbumGetDto> GetDiscontinuedAlbums()
        {
            try
            {
                return _albumRepo.GetAll()
                    .Where(a => a.Status == Status.Discontunied)
                    .Select(a => new AlbumGetDto
                    {
                        Id = a.Id,
                        AlbumName = a.AlbumName,
                        Artist = a.Artist,
                        ReleaseDate = a.ReleaseDate,
                        Price = a.Price,
                        DisctountRate = a.DisctountRate,
                        Status = a.Status,
                        Genre = a.Genre
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred while retrieving discontinued albums: " + ex.Message);
            }
        }

        public IList<AlbumGetDto> GetOnSaleAlbums()
        {
            try
            {
                return _albumRepo.GetAll()
                    .Where(a => a.Status == Status.OnSale)
                    .Select(a => new AlbumGetDto
                    {
                        Id = a.Id,
                        AlbumName = a.AlbumName,
                        Artist = a.Artist,
                        ReleaseDate = a.ReleaseDate,
                        Price = a.Price,
                        DisctountRate = a.DisctountRate,
                        Status = a.Status,
                        Genre = a.Genre
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred while retrieving on-sale albums: " + ex.Message);
            }
        }

        public IList<AlbumGetDto> GetRecentAlbums(int count = 10)
        {
            try
            {
                return _albumRepo.GetAll()
                    .OrderByDescending(a => a.ReleaseDate)
                    .Take(count)
                    .Select(a => new AlbumGetDto
                    {
                        Id = a.Id,
                        AlbumName = a.AlbumName,
                        Artist = a.Artist,
                        ReleaseDate = a.ReleaseDate,
                        Price = a.Price,
                        DisctountRate = a.DisctountRate,
                        Status = a.Status,
                        Genre = a.Genre
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred while retrieving recent albums: " + ex.Message);
            }
        }

        public IList<AlbumGetDto> GetDiscountedAlbums()
        {
            try
            {
                return _albumRepo.GetAll()
                    .Where(a => a.DisctountRate > 0)
                    .OrderByDescending(a => a.DisctountRate)
                    .Select(a => new AlbumGetDto
                    {
                        Id = a.Id,
                        AlbumName = a.AlbumName,
                        Artist = a.Artist,
                        ReleaseDate = a.ReleaseDate,
                        Price = a.Price,
                        DisctountRate = a.DisctountRate,
                        Status = a.Status,
                        Genre = a.Genre
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred while retrieving discounted albums: " + ex.Message);
            }
        }
    }
}
