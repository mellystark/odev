+-----------------+
|    University   |
+-----------------+
| - offices: List<Office>      |
| - departments: List<Department> |
+-----------------+
          |
          |
          |
          v
+-----------------+
|   Department    |
+-----------------+
| - offices: List<Office>   |
+-----------------+
          |
          |
          |
          v
+-----------------+
|      Office     |
+-----------------+
| - employees: List<Employee> |
+-----------------+
          |
          |
          |
          v
+-----------------+     +-----------------+
|   Employee      |     |    Professor    |
+-----------------+     +-----------------+
|                 |     |                 |
+-----------------+     +-----------------+
          |
          |
          |
          v
+-----------------+
|      Clerk      |
+-----------------+
|                 |
+-----------------+





-------------------------------------------------------------------------------------------,

+---------------------+
|       Animal        |
+---------------------+
| - species: string   |
| - weight: float     |
| - age: int          |
+---------------------+
| + getDosage(): void |
| + getFeedSchedule(): void |
+---------------------+
          ^
          |
          |
          |
+---------------------+    +---------------------+    +---------------------+
|        Horse         |    |       Feline         |    |     Rodent           |
+---------------------+    +---------------------+    +---------------------+
|                     |    |                     |    |                     |
+---------------------+    +---------------------+    +---------------------+
| + getDosage(): void |    | + getDosage(): void |    | + getDosage(): void |
| + getFeedSchedule(): void | + getFeedSchedule(): void | + getFeedSchedule(): void |
+---------------------+    +---------------------+    +---------------------+
          ^                     ^
          |                     |
          |                     |
+---------------------+    +---------------------+
|       Zebra          |    |     Tiger            |
+---------------------+    +---------------------+
|                     |    |                     |
+---------------------+    +---------------------+
| + getDosage(): void |    | + getDosage(): void |
| + getFeedSchedule(): void | + getFeedSchedule(): void |
+---------------------+    +---------------------+

-------------------------------------------------------------------------------------------------
+-----------------------+
|     AirlineCompany    |
+-----------------------+
| - id: string          |
+-----------------------+
| + getFlight(): Flight |
+-----------------------+
          |
          |
          | 1
          |
          v
+-----------------------+      +-------------------+
|        Aircraft       |      |    Airport        |
+-----------------------+      +-------------------+
| - id: string          |      | - id: string      |
| - model: string       |      | - name: string    |
| - status: string      |      +-------------------+
+-----------------------+      | + getAirport()    |
| + getFlight(): Flight |      +-------------------+
+-----------------------+
          |
          | n
          |
          v
+-----------------------+
|        Flight         |
+-----------------------+
| - id: string          |
| - departureAirport: Airport |
| - arrivalAirport: Airport   |
| - departureTime: DateTime    |
| - arrivalTime: DateTime      |
| - aircraft: Aircraft        |
| - captain: Pilot            |
| - coPilot: Pilot            |
+-----------------------+
| + getDetails(): void |
+-----------------------+
          ^
          |
          | 1
          |
          v
+-----------------------+
|         Pilot         |
+-----------------------+
| - id: string          |
| - name: string        |
| - experienceLevel: int|
+-----------------------+
| + getExperience(): int|
+-----------------------+
          |
          |
          | n
          |
          v
+-----------------------+
|      AircraftType     |
+-----------------------+
| - type: string        |
| - requiredPilots: int |
+-----------------------+
+-----------------------+
| + getType(): string   |
| + getRequiredPilots(): int |
+-----------------------+


--------------------------------------------------------------------------------------------

+---------------------+
|       User          |
+---------------------+
| - id: string        |
| - name: string      |
| - email: string     |
| - isSubscribed: bool|
+---------------------+
| + subscribe(): void |
| + buyCredits(amount: int): void |
| + rentMovie(movie: Movie): void |
| + buyMovie(movie: Movie): void |
+---------------------+
          |
          | 1
          |
          v
+---------------------+      +---------------------+
|       Subscription  |      |       Credit         |
+---------------------+      +---------------------+
| - id: string        |      | - id: string        |
| - user: User        |      | - amount: decimal   |
| - startDate: DateTime|      | - user: User        |
| - endDate: DateTime |      +---------------------+
+---------------------+      | + addCredits(amount: decimal): void |
| + renew(): void     |      +---------------------+
+---------------------+
          |
          | 1
          |
          v
+---------------------+      +---------------------+
|       Movie         |      |      Rental         |
+---------------------+      +---------------------+
| - id: string        |      | - id: string        |
| - title: string     |      | - rentalDate: DateTime|
| - genre: string     |      | - returnDate: DateTime|
| - price: decimal    |      | - movie: Movie      |
| - isAvailable: bool |      | - user: User        |
+---------------------+      +---------------------+
| + requestMovie(): void |   | + returnMovie(): void |
| + rent(): void       |   | + getDetails(): void |
| + buy(): void        |   +---------------------+
+---------------------+
          |
          | 1
          |
          v
+---------------------+
|      Request        |
+---------------------+
| - id: string        |
| - movie: Movie      |
| - requestDate: DateTime|
| - status: string    |
+---------------------+
| + updateStatus(newStatus: string): void |
+---------------------+

