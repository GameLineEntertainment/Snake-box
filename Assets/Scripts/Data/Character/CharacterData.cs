using UnityEngine;


namespace Snake_box
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Data/Character/CharacterData")]
    public sealed class CharacterData : ScriptableObject
    {
        public float Hp; //здоровье змейки без блоков
        public float Armor;//силовое поле
        public float RegenerationArmor; //регенирация силового поля 
        public float SpeedRotation;// скорость поворота
        public float Speed;// скорость 
        public float Damage;//урон
        public float SlowBlockSpeed;
        public float RamCooldown;
        public float AngularSpeed;//скорость поворота
        public float Fuel;//топливо
        public float FuelLessSpeed;//скорость расхода
        public AnimationCurve Curve;//кривая скорости поворота
    }
}