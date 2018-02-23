﻿using AutoMapper;
using Library.DAL.Repositories;
using Library.Entities.Enums;
using Library.Entities.Models;
using Library.ViewModels;
using Library.ViewModels.Magazine;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class MagazineService
    {
        private readonly MagazineRepository _magazineRepository;

        public MagazineService()
        {
            _magazineRepository = new MagazineRepository();
        }

        public void Add(PostMagazineViewModel magazineView)
        {
            Magazine magazine = Mapper.Map<PostMagazineViewModel, Magazine>(magazineView);
            magazine.TypeOfPublication = TypeOfPublication.Magazine;
            _magazineRepository.Add(magazine);
        }

        public IEnumerable<GetMagazineViewModel> GetAll()
        {
            var result = Mapper.Map<IEnumerable<Magazine>, List<GetMagazineViewModel>>(_magazineRepository.GetAll());
            return result;
        }

        public void Remove(int id)
        {
            _magazineRepository.Remove(id);
        }

        public void Update(PutMagazineViewModel magazineView)
        {
            Magazine magazine = Mapper.Map<PutMagazineViewModel, Magazine>(magazineView);
            _magazineRepository.Update(magazine);
        }
    }
}