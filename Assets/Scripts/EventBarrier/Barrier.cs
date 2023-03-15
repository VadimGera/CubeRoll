using UnityEngine;

namespace EventBarrier
{
    public class Barrier : MonoBehaviour
    {
        private bool isUplift;

        public void Uplift()
        {
            isUplift = true;
        }



        void Update()
        {
            if (isUplift)
            {
                Transform cube = transform.GetChild(0);
                cube.localPosition = Vector3.MoveTowards(cube.localPosition, Vector3.up / 1f, Time.deltaTime / 0.5f);
            }
        }
    }
    
   
}