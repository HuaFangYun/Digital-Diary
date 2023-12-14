﻿using Digital.Diary.Models;
using Digital.Diary.Models.EntityModels.Academic;
using Digital.Diary.Repositories.Abstractions.Academic;
using Digital.Diary.Services.Abstractions.Academic;
using Digital.Diary.Services.Base;

namespace Digital.Diary.Services.Academic
{
    public class CrTableService : Service<CrTable>, ICrTableService
    {
        private ICrTableRepository _repo;

        public CrTableService(ICrTableRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public override Result Create(CrTable entity)
        {
            var result = new Result();
            entity.Id = Guid.NewGuid();
            //code Designation
            var checkEntity = _repo.GetFirstOrDefault(c => c.Name == entity.Name);
            if (checkEntity != null)
            {
                result.IsSucced = false;
                result.ErrorMessages.Add("Same Entity already exist.!");
            }

            if (result.ErrorMessages.Count != 0)
            {
                return result;
            }
            bool isSuccess = _repo.Create(entity);
            if (isSuccess)
            {
                result.IsSucced = true;
                return result;
            }
            result.ErrorMessages.Add("Entity not Created");
            return result;
        }

        public override Result Update(CrTable entity)
        {
            var result = new Result();
            bool isSuccess = _repo.Update(entity);
            if (isSuccess)
            {
                result.IsSucced = true;
                return result;
            }
            result.ErrorMessages.Add("Entity not Updated");
            return result;
        }

        public override Result Remove(CrTable entity)
        {
            var result = new Result();
            bool isSuccess = _repo.Remove(entity);
            if (isSuccess)
            {
                result.IsSucced = true;
                return result;
            }

            result.ErrorMessages.Add("Entity not Removed");

            return result;
        }
    }
}