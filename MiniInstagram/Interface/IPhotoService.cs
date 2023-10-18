﻿
using MiniInstagram.Domain.Entity;
namespace MiniInstagram.Interface;
public interface IPhotoService
{
    public ValueTask<Photo> CreateAsync(IFormFile file, string path, long userId);
    public ValueTask<IEnumerable<Photo>> GetPhotoByUserIdAsync(long userId);
    public ValueTask<Photo> DeleteAsync(string path,Photo photo);
}