using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P329ConsoleAppPractise.Services
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teacher[] _teachers = new Teacher[10];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 9)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 10 muellim qeyd oluna biler");

                return;
            }

            _teachers[_currentIndex++] = (Teacher)entity;

            Console.WriteLine("Teacher ugurla elave edildi");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (id == _teachers[i].Id)
                {
                    found = true;

                    for (int j = i; j < _teachers.Length - 1; j++)
                    {
                        _teachers[j] = _teachers[j + 1];
                    }

                    _currentIndex--;

                    Console.WriteLine($"{id} nomreli teacher silindi");

                    return;
                }
            }
        }
        public Entity Get(int id)
        {
            foreach (var item in _teachers)
            {
                if (item == null)
                    continue;

                if (item.Id == id)
                    return item;
            }

            Console.WriteLine("Not found");

            return null;
        }

        public Entity[] GetAll()
        {
            return _teachers;
        }

        public void Print()
        {
            foreach (var item in _teachers)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;
                if (_teachers[i].Id == id)
                {
                    _teachers[i] = (Teacher)entity;
                    Console.WriteLine("Ugurla deyisdirildi");
                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
