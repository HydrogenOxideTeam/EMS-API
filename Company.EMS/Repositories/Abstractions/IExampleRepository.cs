﻿using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;

namespace Company.EMS.Repositories.Abstractions;

public interface IExampleRepository: IRepository<ExampleEntity>
{
    Task<ExampleEntity> GetByNameAsync(string name);
}