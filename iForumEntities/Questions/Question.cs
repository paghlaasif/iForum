﻿using System;
using System.Collections.Generic;
using iForumEntities.Answers;
using iForumEntities.Users;
using iInfrastructure.Entities;

namespace iForumEntities.Questions
{
    public class Question : iEntity
    {
        public         int                 Id          { get; set; }
        public         string              Title       { get; set; }
        public         string              Description { get; set; }
        public         DateTime            AskedOn     { get; set; }
        public         DateTime            ResolvedOn  { get; set; }
        public         int                 UserId      { get; set; }
        public virtual User                User        { get; set; }
        public virtual ICollection<Answer> Answers     { get; set; }
    }
}