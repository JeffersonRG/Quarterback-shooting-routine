using UnityEngine;
using SpaceAccuracy;


namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {
       //ublic ShootProjectile shoot;
        [Header("Output")]
        public StarterAssetsInputs starterAssetsInputs;
        public ShootProjectile shoot;
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
