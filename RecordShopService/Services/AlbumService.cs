using RechordShopApp.Concerete;
using RechordShopApp.Enum;
using RecordShopAppDAL.Interface;
using RecordShopService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordShopService.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepo _albumRepo;

        public AlbumService(IAlbumRepo repo)
        {
            _albumRepo = repo;
        }

        public int Create(AlbumCreateDto model)
        {
            try
            {
                var album = new Album
                {
                    AlbumName = model.AlbumName,
                    Artist = model.Artist,
                    CreateDate = DateTime.Now,
                    DisctountRate = model.DisctountRate,
                    Genre = model.Genre,
                    Price = model.Price,
                    Status = model.Status,
                    ReleaseDate = model.ReleaseDate,
                };

                return _albumRepo.Create(album);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Invalid input: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not create album: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                var album = _albumRepo.GetById(id);
                if (album != null)
                {
                    return _albumRepo.Delete(album);
                }
                throw new Exception("Album not found...");
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Invalid ID: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not delete album: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public IList<AlbumGetDto> GetAll()
        {
            try
            {
                return _albumRepo.GetAll().Select(x => new AlbumGetDto
                {
                    Id = x.Id,
                    AlbumName = x.AlbumName,
                    Artist = x.Artist,
                    DisctountRate = x.DisctountRate,
                    Genre = x.Genre,
                    Price = x.Price,
                    Status = x.Status,
                    ReleaseDate = x.ReleaseDate,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }

        public AlbumGetDto GetById(int id)
        {
            try
            {
                var album = _albumRepo.GetById(id);
                if (album == null)
                    throw new Exception("Album not found");

                return new AlbumGetDto
                {
                    Id = album.Id,
                    AlbumName = album.AlbumName,
                    Artist = album.Artist,
                    Price = album.Price,
                    Status = album.Status,
                    ReleaseDate = album.ReleaseDate,
                    DisctountRate = album.DisctountRate,
                    Genre = album.Genre
                };
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Invalid ID: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not retrieve album: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }
 

        public int Update(AlbumGetDto model)
        {
            try
            {
                var album = new Album
                {
                    AlbumName = model.AlbumName,
                    Artist = model.Artist,
                    DisctountRate = model.DisctountRate,
                    Genre = model.Genre,
                    Status = model.Status,
                    Price = model.Price,
                    ReleaseDate = model.ReleaseDate,
                    Id = model.Id
                };

                return _albumRepo.Update(album);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Invalid input: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Could not update album: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error occurred: " + ex.Message);
            }
        }
    }
}
