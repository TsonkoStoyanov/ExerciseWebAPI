﻿using System;

namespace Messages.Models
{
    public class Message
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public string  Username { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
