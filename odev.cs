using System;
using System.Collections.Generic;

// Abstraction: ElevatorComponent abstract class
public abstract class ElevatorComponent
{
    public abstract void Operate();
}

// Encapsulation: Elevator class
public class Elevator : ElevatorComponent
{
    public int CurrentFloor { get; private set; }
    public int Capacity { get; private set; }
    private ElevatorControlPanel controlPanel;
    private bool isMoving;

    public Elevator(int capacity)
    {
        Capacity = capacity;
        CurrentFloor = 1; // Starting at the first floor
        controlPanel = new ElevatorControlPanel();
        isMoving = false;
    }

    public void CallElevator(int floor)
    {
        // Simulate calling elevator
        Console.WriteLine($"Elevator called to floor {floor}");
        Move(floor);
    }

    public void Move(int targetFloor)
    {
        // Simulate moving elevator
        Console.WriteLine($"Elevator moving from floor {CurrentFloor} to floor {targetFloor}");
        CurrentFloor = targetFloor;
        controlPanel.UpdateDisplay(targetFloor);
    }

    public override void Operate()
    {
        // Elevator operation logic
    }
}

// Encapsulation: ElevatorControlPanel class
public class ElevatorControlPanel
{
    public void UpdateDisplay(int floor)
    {
        // Update display logic
        Console.WriteLine($"Control Panel: Elevator is now at floor {floor}");
    }

    public void OpenDoors()
    {
        Console.WriteLine("Elevator doors opening...");
    }

    public void CloseDoors()
    {
        Console.WriteLine("Elevator doors closing...");
    }
}

// Encapsulation: Floor class
public class Floor
{
    public int FloorNumber { get; private set; }
    private List<ElevatorCallButton> callButtons;

    public Floor(int floorNumber)
    {
        FloorNumber = floorNumber;
        callButtons = new List<ElevatorCallButton>
        {
            new ElevatorCallButton("Up"),
            new ElevatorCallButton("Down")
        };
    }

    public void CallElevator(string direction)
    {
        Console.WriteLine($"Elevator called {direction} from floor {FloorNumber}");
    }
}

// Encapsulation: ElevatorCallButton class
public class ElevatorCallButton
{
    public string Direction { get; private set; }

    public ElevatorCallButton(string direction)
    {
        Direction = direction;
    }

    public void PressButton()
    {
        Console.WriteLine($"Button pressed for {Direction} direction");
    }
}

// Example Usage
public class Program
{
    public static void Main()
    {
        // Create floors
        List<Floor> floors = new List<Floor>();
        for (int i = 1; i <= 12; i++)
        {
            floors.Add(new Floor(i));
        }

        // Create elevators
        List<Elevator> elevators = new List<Elevator>();
        for (int i = 0; i < 5; i++)
        {
            elevators.Add(new Elevator(6));
        }

        // Simulate elevator call
        elevators[0].CallElevator(5);
        floors[4].CallElevator("Up");
    }
}
