
## About Garden App 🌳
The Garden App allows users to define gardens on a map by specifying their areas, and to add plants to these gardens. Additionally, users can store photos and notes about their gardens and plants, and share their gardens with other users.

### Database Diagram
View database diagram of the Garden App from [here](https://drawsql.app/teams/me-438/diagrams/gardenapp).

![GardenApp_DatabaseDiagram](https://github.com/snnehir/Turkcell-GYGY3-Bootcamp-Exercises/blob/master/SQL/GardenAppDiagram.png)

### Tables

- **Users**: Stores user information.

- **Gardens**: Stores garden information.

- **Plants**: Stores plant information along with garden's id and plant type's id.

- **PlantTypes**: Stores plant type information.

- **UserGardens**: Stores ownership information for gardens. (Many-to-many relation between user and garden.)

- **GardenNotes**: Stores garden note information along with garden's id.

- **PlantNotes**: Stores plant note information along with plant's id.
