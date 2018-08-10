namespace VRTK.Examples.Archery
{
    using UnityEngine;

    public class BowAnimation : MonoBehaviour
    {
        public Animation animationTimeline;

        public void SetFrame(float frame)
        {
            animationTimeline["bowPull"].speed = 0;
            animationTimeline["bowPull"].time = frame;
            animationTimeline.Play("bowPull");
        }
    }
}