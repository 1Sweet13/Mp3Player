using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace Mp3_player.cs
{
    public static class BassLike
    {
        // Частота дискретизации 
        private static int HZ = 44100;

        // будет хранить состояние иницализации библиотеки 
        public static bool InitDefaultDevice;

        // Канал 
        public static int Stream;
        // Громкость
        public static int Volume = 100;

        // Инициализация BassDll
        private static bool InitBass(int HZ)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, HZ, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);

            }
            return InitDefaultDevice;
        }


        // Play 
        public static void Play(string filename, int vol)
        {
            Stop();
            if (InitBass(HZ))
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if (Stream != 0)
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
        }

        // Стоп
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }

        // Получение длительности канала в секундах
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }


        // Получение текущей позиции в секундах 
        public static int GetPosOfStream(int stream)
        {
             long pos = Bass.BASS_ChannelGetPosition(stream);
             int poseSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
             return poseSec;
        }

        // Перемотка

        public static  void SetPoseOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }
  

        // Установка громкости 
        public static void SetVolumeToStream(int stream, int vol) 
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
    }
}
