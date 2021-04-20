# STD
# Plan
# Scuffed Tower Defence

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