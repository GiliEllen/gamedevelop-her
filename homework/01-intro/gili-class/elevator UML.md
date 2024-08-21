+-----------------------------------------------------------+
|                         Elevator                          |
+-----------------------------------------------------------+
| - currentFloor: int                                       |
| - targetFloor: int                                        |
| - selectedFloors: List<int>                               |
| - capacity: int                                           |
| - isMoving: bool                                          |
| - doorOpen: bool                                          |
| - isFanOn: bool                                           |
| - isAlarmOn: bool                                         |
+-----------------------------------------------------------+
| + selectFloor(floor: int): void                           |
|     // Adds a floor to the selectedFloors list            |
| + goToNextFloor(): void                                   |
|     // Moves to the next floor in selectedFloors and      |
|     // removes it from the list                           |
| + openDoor(): void                                        |
|     // Opens the elevator door                            |
| + closeDoor(): void                                       |
|     // Closes the elevator door                           |
| + moveUp(): void                                          |
|     // Moves the elevator up one floor                    |
| + moveDown(): void                                        |
|     // Moves the elevator down one floor                  |
| + stop(floor: int, targetFloor:int): void                 |
|     // stops the elevator id reached target floor         |
| + emergencyStop(): void                                   |
|     // Immediately stops the elevator                     |
| + lockElevator(): void                                    |
|     // Immediately stops the elevator and opens the doors |
| + isOverCapacity(): bool                                  |
|     // Returns true if the current load exceeds capacity  |
| + turnOnFan(): void                                       |
|     // Turn on the elevator fan                           |
| + turnOffFan(): void                                      |
|     // Turn off the elevator fan                          |
| + toggleAlarm(): void                                     |
|     // toggle alarm status                                |
| + unselectFloor(floor: int): void                         |
|     // loop list of selected floor,                       |
|     // if floor exist, remove it                          |
+-----------------------------------------------------------+
