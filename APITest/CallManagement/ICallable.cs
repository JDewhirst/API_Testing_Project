﻿using DataModel;
using System.Threading.Tasks;
namespace APITest
{
    public interface ICallable
    {
        int StatusCode { get; }
        string StatusDescription { get; }

        Task DeleteFilm(string request);

        Task<Result> AddFilm(string request);

        Task<Result> UpdateFilm(string request);

        Task<Result> Request(string request);
        Task<Result> RequestFilmography(string v);
    }
}