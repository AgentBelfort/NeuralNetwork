using System.Diagnostics;

namespace Neuron
{
    internal class FloatVector : List<float>
    {
        public FloatVector()
        {
            
        }

        public FloatVector(params float[] elements)
        {
            foreach (var element in elements)
                Add(element);
        }

        // перегрузки умножений
        public static FloatVector operator *(FloatVector vector1, FloatVector vector2)
        {
            Debug.Assert(vector1.Count == vector2.Count);
            var result = new FloatVector();
            for (var i = 0; i < vector1.Count; i++)
                result.Add(vector1[i]*vector2[i]);
            return result;
        }
        public static FloatVector operator *(FloatVector vector, float value)
        {
            var result = new FloatVector();
            for (var i = 0; i < vector.Count; i++)
                result.Add(vector[i] * value);
            return result;
        }
        public static FloatVector operator *(float value, FloatVector vector)
        {
            return vector * value;
        }

        public static FloatVector operator -(FloatVector vector1, FloatVector vector2)
        {
            Debug.Assert(vector1.Count == vector2.Count);
            var result = new FloatVector();
            for (var i = 0; i < vector1.Count; i++)
                result.Add(vector1[i] - vector2[i]);
            return result;
        }

        public static float Sum(FloatVector vector)
        {
            float result = 0;
            foreach (var element in vector)
                result += element;
            return result;
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < Count; i++)
                result += $"{base[i]} ";
            return result.TrimEnd();
        }
    }
}
