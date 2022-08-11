using Divisao.Exceptions;

namespace Divisao.Services;

public class DivisaoService : IDivisaoService
{
    public double calculate(double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new DivisaoZeroException("É impossível dividir por 0");
        }

        return dividendo / divisor;
    }
}