using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeCommandCenter
{
    internal class PlayMusic : ICommand
    {
        private readonly AudioSystem audioSystem;
        private readonly string genre;

        public PlayMusic(AudioSystem audioSystem, string genre)
        {
            this.audioSystem = audioSystem;
            this.genre = genre;
        }
    
        public void Execute() => audioSystem.SetPlaylist(genre);

        public void Undo() => audioSystem.StopMusic();
    }
}
