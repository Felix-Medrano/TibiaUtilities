using NAudio.Wave;
using NAudio.Wave.SampleProviders;

using System;
using System.Threading.Tasks;

namespace Tibia_Utilities.Core
{
  public static class SoundManager
  {
    private static float _volume = 1.0f; // Volumen predeterminado (1.0 = 100%)

    /// <summary>
    /// Establece el volumen de reproducción (rango: 0.0 a 1.0).
    /// </summary>
    public static float Volume
    {
      get => _volume;
      set
      {
        if (value < 0.0f || value > 1.0f)
          throw new ArgumentOutOfRangeException(nameof(value), "El volumen debe estar entre 0.0 y 1.0.");
        _volume = value;
      }
    }

    /// <summary>
    /// Reproduce un archivo de sonido desde los recursos con el volumen actual.
    /// </summary>
    /// <param name="resourceStream">El flujo de recursos del archivo de sonido.</param>
    public static void PlaySoundFromResources(System.IO.Stream resourceStream)
    {
      Task.Run(() =>
      {
        using (var waveOut = new WaveOutEvent())
        {
          // Usar WaveFileReader para leer el flujo de audio
          using (var audioFile = new WaveFileReader(resourceStream))
          {
            var volumeProvider = new VolumeSampleProvider(audioFile.ToSampleProvider())
            {
              Volume = _volume // Aplicar el volumen
            };

            waveOut.Init(volumeProvider);
            waveOut.Play();

            // Esperar hasta que termine la reproducción sin bloquear el hilo principal
            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
              System.Threading.Thread.Sleep(100); // Pequeña pausa para evitar uso excesivo de CPU
            }
          }
        }
      });
    }
  }
}
