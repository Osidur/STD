# STD
# BALLOONA POPPA (NEW AND FRÄSCH PLANERING FÖR E GUIDE UPPGIFT)

Planering

Jag ska kolla igenom hela guiden först för att kunna göra resten av planeringen mer effektivt. Sen ska jag ta redå på om jag har några andra problem.

Hur planeringen följdes

Jag kollade inte igenom hela guiden innan jag började koda vilket resulterade i att jag inte exakt förstod vad jag skrev. På grund av detta behövde jag gå igenom min kod senare och försöka tyda vad den gör för att kunna kommentera. Själva planeringen var också otroligt outvecklad men eftersom jag följde en guide så spelade detta inte så stor roll.

Problem

Jag stötte på några problem när det kom till bilderna. Jag sökte hjälp hos Fabian och han sade att jag behövde ändra bildernas "Build Action" till resource i properties. Jag använde i början den totala sökvägen för bilderna vilket inte skulle fungera för andra datorer än den programmet skrevs på. Jag ändrade till en sökväg som skulle fungera för alla datorer. "pack://application:,,," sökvägen istället för "C://user/blabla..." Ett annat problem jag stötte på var att jag inte hade skrivit balloon's tag "Balloon" med litet b. På grund av detta kom det inte fram några ballonger men det var ett enkelt problem att fixa. 

Extra funktionalitet

Jag ändrade bilderna, bakgrund, ballonger och antal bilder. Det överväldigande temat är NTI Kronhus men det finns även Obama. Detta var inte helt planerat men jag hade det i bakhuvet att använda egna bilder. Det var väldigt enkelt att lägga till bilder; jag ändrade på en siffra i en for loop och lade till några cases i switchsatsen. 

Det finns inget sätt att förlora spelet så jag vet inte om RestartGame funktionen används någon gång.

Utvärdering av arbetsgång

Jag la tillräckligt med tid på uppgiften, jag visste att det inte skulle ta lång tid och det gjorde det inte. 
Jag hade alla förkunskaper jag behövde för uppgiften.

# Scuffed Tower Defence (OLD AND GAMMAL PLANERING FOR OLD AND GAMMAL GAME)

A tower defence game with: menu, round system, moving enemies, static towers, projectiles, point system, player health system, money system, successionally harder.

    Menu
        Need buttons.
            Start, quit, help.
        Need navigation.
            Mouse movement.

    Round system (Round)
        Need a way to determine how many Enemies are sent onto Path.
            Amount of Enemies = Round + 1
        Need a way to find out when a round is over.
            Calculate how many enemies are on screen. When none; start new round.

    Moving enemies (Enemies)
        Need a Path to move along.
            https://www.youtube.com/watch?v=kSoVL6MuL5o&list=PLqOxH0kcZ8wMiQOlxHDl97xF7U0Je5pEC&index=6&ab_channel=MooICT
        Need a speed to move with.
            https://www.youtube.com/watch?v=kSoVL6MuL5o&list=PLqOxH0kcZ8wMiQOlxHDl97xF7U0Je5pEC&index=6&ab_channel=MooICT
        Need a hitbox.
            https://www.youtube.com/watch?v=m1n2W6OwsUc&list=PLqOxH0kcZ8wMiQOlxHDl97xF7U0Je5pEC&index=8&ab_channel=MooICT
        Need a texture.
            Image set onto a point.
        Need a despawn function.
            When Enemy is on end of Path; Despawn Enemy.
        Prefer hitpoints.
            When collision between projectile and Enemy; HP - 1.
        Prefer SFX.
            Clonk on a sound file onto sum' events.

    Static towers (Towers)
        Need a point to sit on.
            Point gotten from last mouse position when dragging the Tower.
        Need a way to aim on Enemies.
            Mouse or calculate a line between Tower and all Enemies then send projectile on shortest line.
        Need a texture.
            Image set onto a point.
        Prefer SFX.
            Clonk on a sound file onto sum events.

    Projectiles
        Need a path to move along.
            https://www.youtube.com/watch?v=kSoVL6MuL5o&list=PLqOxH0kcZ8wMiQOlxHDl97xF7U0Je5pEC&index=6&ab_channel=MooICT
        Need a speed to move with.
            https://www.youtube.com/watch?v=kSoVL6MuL5o&list=PLqOxH0kcZ8wMiQOlxHDl97xF7U0Je5pEC&index=6&ab_channel=MooICT
        Need a texture.
            Image set onto a point.
        Prefer SFX.
            Clonk on a sound file onto sum events.

    Point system (Points)
        Need a way to count amount of rounds.
            When round over; RoundCount++.

    Player health system (Player_HP)
        Need a way to keep track of Player_HP.
            Amount of PHP determined at start.
        Need a way to change Player_HP.
            When Enemy Despawn; Player_HP--.
        Need a way to end game when PHP is zero.
            When Player_HP = zero; end game.

    Money system (Money)
        Need a way to convert Enemy deaths into money.
            When Enemy death; Money++.
        Prefer a way to convert end of round into money.
            When round over; Money++.

    Successionally harder (Difficulty)
        Need a way to make higher index rounds send out more Enemies.
            When round over; EnemyCount++.

