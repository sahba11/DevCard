﻿namespace DevCard_Mvc.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Service(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
