using SwampAttack.Runtime.View.SliderValueChangers;

namespace SwampAttack.Runtime.View.EnemyWavesSystem
{
    public class DefaultWavesCycleProgressView : ViewWithSmoothSliderValueChanger, IWavesCycleProgressView
    {
        public void Visualize(int completedCount, int maxValue) => ChangeSliderValue(completedCount, maxValue);
        private void Start() => Slider.value = 0;
    }
}