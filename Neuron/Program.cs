namespace Neuron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Нейронка из главы 5
            Neuron neuron = new Neuron();
            neuron.weights = new FloatVector(0.1f, 0.2f, -0.1f);
            var result = neuron.MakePrediction(new FloatVector(8.5f, 0.65f, 1.2f));
            //Console.WriteLine($"Result is: {result}");

            // обучение
            FloatVector input = new FloatVector(8.5f, 0.65f, 1.2f); // входное значение
            float goal = 1f; // целевое значение
            float alpha = 0.3f; // альфа-коэффициент
            neuron.Educate(20, input, goal, alpha);
        }
    }
}