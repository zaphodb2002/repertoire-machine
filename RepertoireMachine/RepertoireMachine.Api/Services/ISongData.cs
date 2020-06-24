using RepertoireMachine.Api.Data.Entities;
using RepertoireMachine.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepertoireMachine.Api.Services
{
    public interface ISongData
    {
        public List<Song> GetSongs();
        public Song AddSong(Song songToAdd);
        public Song UpdateSong(uint idToUpdate, Song updatedSong);
        public uint? DeleteSong(uint idToDelete);
    }
}
