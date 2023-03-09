namespace Neuron
{
    internal class Neuron
    {
        public FloatVector weights { get; set; } = new();

        /*public void SetWeights(params float[] weights)
        {
            this.weights = new Vector<float>(weights);
        }*/

        public float MakePrediction(FloatVector inputs)
        {
            return FloatVector.Sum(weights * inputs);
        }

        public void Educate(int cyclesCount, FloatVector input, float goal, float alpha = 0.1f)
        {
            for (int i = 0; i < cyclesCount; i++)
            {
                float prediction = MakePrediction(input); // делаем предсказание
                float error = (float)Math.Pow(prediction - goal, 2); // ошибка
                float delta = (prediction - goal); // считаем разницу (чистая ошибка)
                FloatVector weightDeltas = delta * input;
                weightDeltas[0] = 0; // заморозка веса
                weights -= (weightDeltas * alpha); // корректируем

                Console.WriteLine($"Prediction: {prediction}\tDelta: {delta}\tWeights: {weights}");
            }
        }
    }
}
