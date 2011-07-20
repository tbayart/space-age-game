using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace SpaceShooter
{
    public static class SFX
    {
       public static ContentManager Content;
       public static SoundEffect sfx;
       public static string lastsongname;
        public static void  PlayEffect(string assetName)
        {
            sfx = Content.Load<SoundEffect>(assetName);
            
            sfx.Play();
        }

        public static void PlaySong(string assetName)
        {
            if (!(lastsongname == assetName))
            {
                MediaPlayer.IsRepeating = true;

                Song s;

                s = Content.Load<Song>(assetName);

                MediaPlayer.Play(s);
            }
            lastsongname= assetName;
        }

        public static void StopSong()
        {
            MediaPlayer.Stop();
            lastsongname = "";
        }
    }
}
