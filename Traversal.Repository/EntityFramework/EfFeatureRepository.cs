﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Repository.Repository;

namespace Traversal.Repository.EntityFramework
{
    public class EfFeatureRepository : GenericRepository<Feature> , IFeatureRepository
    {
    }
}
