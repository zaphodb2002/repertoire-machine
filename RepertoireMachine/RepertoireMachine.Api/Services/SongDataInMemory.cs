using RepertoireMachine.Api.Data.Entities;
using RepertoireMachine.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepertoireMachine.Api.Services
{
    public class SongDataInMemory : ISongData
    {
        private List<Song> songs;

        public SongDataInMemory()
        {
            // Dummy Data
            songs = new List<Song> { 
                new Song {Id = 1, Title = "Another One Bites The Dust"},
                new Song {Id = 2, Title = "We Are The Champions"},
                new Song {Id = 3, Title = "Space Oddity"},
                new Song {Id = 4, Title = "Under Pressure"},
            };
        }
        public Song AddSong(Song songToAdd)
        {
            // TODO: Verify that it's not a duplicate
            uint nextId = songs.Max(x => x.Id);
            songToAdd.Id = nextId;
            songs.Add(songToAdd);

            return songToAdd;
        }

        public uint? DeleteSong(uint idToDelete)
        {
            var songToDelete = songs.FirstOrDefault(x => x.Id == idToDelete);

            if (songToDelete != null)
            {
                songs.Remove(songToDelete);
                return idToDelete;
            }
            else
            {
                return null;
            }

        }

        public List<Song> GetSongs()
        {
            return songs;
        }

        public Song UpdateSong(uint idToUpdate, Song updatedSong)
        {
            var songToUpdate = songs.FirstOrDefault(x => x.Id == idToUpdate);
            if (songToUpdate != null)
            {
                songToUpdate = updatedSong;
                return songToUpdate;
            }
            else
            {
                return null;
            }
        }
    }
}
