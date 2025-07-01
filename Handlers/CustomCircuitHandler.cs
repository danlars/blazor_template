using Microsoft.AspNetCore.Components.Server.Circuits;

namespace weather.Handlers;

public class CustomCircuitHandler : CircuitHandler
{
    private readonly ILogger<CustomCircuitHandler> _logger;

    public CustomCircuitHandler(ILogger<CustomCircuitHandler> logger)
    {
        _logger = logger;
    }

    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Blazor Circuit Opened: {CircuitId}", circuit.Id);
        return base.OnCircuitOpenedAsync(circuit, cancellationToken);
    }

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Blazor Circuit Closed: {CircuitId}", circuit.Id);
        return base.OnCircuitClosedAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        _logger.LogWarning("Blazor Circuit Connection Down: {CircuitId}", circuit.Id);
        return base.OnConnectionDownAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Blazor Circuit Connection Up: {CircuitId}", circuit.Id);
        return base.OnConnectionUpAsync(circuit, cancellationToken);
    }
}