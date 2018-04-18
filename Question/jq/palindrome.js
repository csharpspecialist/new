
//.split changes things into an array

function palindrome (inputword) {

inputword = inputword.toLowerCase();
//changing our input into an array below
let charArr = inputword.split('');

//creating a clean array of chars that don't have any punctation
let validChars = 'abcdefghijklmnopqrstuvwxyz'.split('');

//creating a clean array
let checkingInputArray = [];

charArr.forEach(char => {

if(validChars.indexOf(char) > -1) checkingInputArray.push(char);

})

if(checkingInputArray.join('') === checkingInputArray.reverse().join('')) return true;
else
return false;




document.getElementById('hold').innerHTML = checkingInputArray;

}

 console.log(palindrome(" madam i'm adam"));





