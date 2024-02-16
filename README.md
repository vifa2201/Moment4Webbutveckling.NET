# Moment 4 webbtjänst
Nedan föjet en beskrivning av alla sökvägar:

## Artist
### GET /api/Artist
Beskrivning: Hämtar alla artister.

### POST /api/Artist
Beskrivning: Skapar en ny artist.

### GET /api/Artist/{id}
Beskrivning: Hämtar en specifik artist med angivet ID.

### PUT /api/Artist/{id}
Beskrivning: Uppdaterar information om en artist med angivet ID.

### DELETE /api/Artist/{id}
Beskrivning: Tar bort en artist med angivet ID.

## Category
GET /api/Category
Beskrivning: Hämtar alla kategorier.

### POST /api/Category
Beskrivning: Skapar en ny kategori.

### GET /api/Category/{id}
Beskrivning: Hämtar en specifik kategori med angivet ID.

### PUT /api/Category/{id}
Beskrivning: Uppdaterar information om en kategori med angivet ID.

### DELETE /api/Category/{id}
Beskrivning: Tar bort en kategori med angivet ID.

## Song
### GET /api/Song
Beskrivning: Hämtar alla sånger.

### POST /api/Song
Beskrivning: Skapar en ny sång.

### GET /api/Song/{id}
Beskrivning: Hämtar en specifik sång med angivet ID.

### PUT /api/Song/{id}
Beskrivning: Uppdaterar information om en sång med angivet ID.

### DELETE /api/Song/{id}
Beskrivning: Tar bort en sång med angivet ID.

#### Exempel
Lägg till låt

{
    "Title": "Min sång",
    "Length": 180,
    "ArtistId": 1,
    "CategoryId": 2
}

Lägg till artist

{
    "Name": "Aristens namn",
   
}

Lägg till kategori

{
    "Name": "Kategorins namn",
   
}

