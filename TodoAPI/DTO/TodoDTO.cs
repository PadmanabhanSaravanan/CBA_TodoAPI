﻿namespace TodoAPI.DTO
{
    public class TodoDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public Guid UserId { get; set; }
    }
}
