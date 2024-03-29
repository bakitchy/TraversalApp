﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Service.Abstract;

namespace Traversal.Service.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TAdd(Testimonial t)
        {
            _testimonialRepository.Add(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialRepository.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialRepository.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialRepository.Update(t);
        }
    }
}
