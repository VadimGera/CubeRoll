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
                transform.position += new Vector3(0, Time.deltaTime * 0.2f, 0);
            }
        }
    }
    
   
}