


function harmless (noteText,magText) {

let noteArr = noteText.split(" ");
//.split changes things into an array
let magArr = magText.split(" ");
let magObj = {};
//.split changes things into an array
magArr.forEach(word => {
	if(!magObj[word] ) magObj[word] = 0;
magObj[word]++
});

// console.log(magObj);



let noteIsPoss = true;

noteArr.forEach(word => {
if(magObj[word]) {
magObj[word]--;
if (magObj[word] < 0)
noteIsPoss = false;
}
else noteIsPoss = false;

});

document.getElementById('small').innerHTML = noteIsPoss;

}

 harmless("how flies time not", "how time flies when time is having time")





