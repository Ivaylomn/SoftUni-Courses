function Songs(array) {
    class Song {
        constructor(typeList, name, time) {
            this.typeList = typeList,
                this.name = name,
                this.time = time
        }
    }

    let n = array.shift();
    let songType = array.pop();
    let songs = [];
    for (let i = 0; i < n; i++) {
        let [type, name, time] = array[i].split('_');
        let song = new Song(type, name, time);
        songs.push(song);
    }

    if (songType == 'all') {
        songs.forEach((x) => console.log(x.name));
    } else {
        songs.filter((x) => x.typeList === songType).forEach((x) => console.log(x.name));
    }
}

Songs([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'favourite'
]);
Songs([4,
    'favourite_DownTown_3:14',
    'listenLater_Andalouse_3:24',
    'favourite_In To The Night_3:58',
    'favourite_Live It Up_3:48',
    'listenLater'
]);
Songs([2,
    'like_Replay_3:15',
    'ban_Photoshop_3:48',
    'all'
]);