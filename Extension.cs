using Unity.UIWidgets.ui;
using UnityEngine;

namespace FinGameWorks.Scripts.Helpers
{
    public static partial class Extension
    {
        public static Offset LerpTo(this Offset currentOffset, Offset nextOffset, float progress)
        {
            return new Offset(Mathf.Lerp(currentOffset.dx,nextOffset.dx,progress),
                Mathf.Lerp(currentOffset.dy,nextOffset.dy,progress));
        }
        public static Offset DampTo(this Offset currentOffset, Offset nextOffset, ref Offset speed, float time)
        {
            float speedX = 0;
            float speedY = 0;
            Offset offset = new Offset(Mathf.SmoothDamp(currentOffset.dx,nextOffset.dx,ref speedX,time),
                Mathf.SmoothDamp(currentOffset.dy,nextOffset.dy,ref speedY, time));
            speed = new Offset(speedX, speedY);
            return offset;
        }
    }
}