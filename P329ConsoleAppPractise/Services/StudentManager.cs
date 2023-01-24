﻿using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P329ConsoleAppPractise.Services
{
    internal class StudentManager : ICrudService, IPrintService
    {
        private Student[] _students = new Student[100];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 99)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 100 telebe qeyd oluna biler");

                return;
            }

            _students[_currentIndex++] = (Student)entity;

            Console.WriteLine("Student ugurla elave edildi");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                    continue;

                if (id == _students[i].Id)
                {
                    found = true;

                    for (int j = i; j < _students.Length - 1; j++)
                    {
                        _students[j] = _students[j + 1];
                    }

                    _currentIndex--;

                    Console.WriteLine($"{id} nomreli student silindi");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} nomreli student tapilmadi");
            }
        }

        public Entity Get(int id)
        {
            foreach (var item in _students)
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
            return _students;
        }

        public void Print()
        {
            foreach (var item in _students)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                    continue;
                if (_students[i].Id == id)
                {
                    _students[i] = (Student)entity;
                    Console.WriteLine("Ugurla deyisdirildi");
                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
