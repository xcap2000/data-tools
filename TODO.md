# TODO

## Tasks

Status:

Running - The task is running.
Stopped - The task is stopped.
Paused  - The task is paused.
Paused (automatically) - The task is paused automatically, and will resume automatically

Methods
Task.Start  -> Puts a task in the "Running" state
Task.Pause  -> Puts a task in the "Paused" state (Paused.ByUser|Paused.BySystem)
Task.Resume -> Puts a task in the "Running" state
Task.Stop   -> Puts a task in the "Stopped" state