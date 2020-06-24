using AutoMapper;
using RepertoireMachine.Api.Data.Entities;
using RepertoireMachine.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RepertoireMachine.Api.Data
{
    public class SongProfile : Profile
    {
        public SongProfile()
        {
            this.CreateMap<Song, SongModel>();
        }
    }
}
