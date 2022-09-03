﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        //REPO ADI ALTINDA NESNE TÜRETİYORUZ
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {

            return repo.List();

        }

        public void CategoryAddBL(Category p)
        {

            if(p.CategoryName==""  || p.CategoryName.Length <= 3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {

                //HATA MESAJI

            }
            else
            {

                repo.Insert(p);

            }

        }


    }
}
