using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams.Effects;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestEQ
{
    class Program
    {
        static void Main(string[] args)
        {

            ////

            Audio a = new Audio();
            a.PlayASound();
        /////



        }
    }

    public class Audio
    {

        public void PlayASound()
        {
            //Contains the sound to play
            using (IWaveSource soundSource = GetSoundSource())
            {
                //SoundOut implementation which plays the sound
                using (ISoundOut soundOut = GetSoundOut())
                {
                    //Tell the SoundOut which sound it has to play
                    soundOut.Initialize(soundSource);
                    //Play the sound
                    soundOut.Play();

                    Thread.Sleep(20000);

                    //Stop the playback
                   soundOut.Stop();
                }
            }
        }

        private ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            else
                return new DirectSoundOut();
        }

        private IWaveSource GetSoundSource()
        {
            //return any source ... in this example, we'll just play a mp3 file
            return CodecFactory.Instance.GetCodec(@"C:\Users\jayweb\Downloads\Roy Ayers Liquid love.mp3");
        }
    }

}
