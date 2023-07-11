﻿using System;

namespace Imi.Project.Api.Core.Entities
{
    public abstract class BaseEntity
    {

        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
