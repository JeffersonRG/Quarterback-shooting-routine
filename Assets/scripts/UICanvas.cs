using UnityEngine;
using StarterAssets;

namespace SpaceAccuracy
{
    public class UICanvas : MonoBehaviour
    {
        public ShootProjectile shoot;
        [Header("Output")]
        public StarterAssetsInputs starterAssetsInputs;
       
        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            starterAssetsInputs.LookInput(virtualLookDirection);
        }
        public void VirtualonFireInput(bool virtualFire)
        {
            shoot.FireInput(virtualFire);
        }
    }
}