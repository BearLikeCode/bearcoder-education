var isPalindrome = function(x) {
    return x == x.toString().split('').reverse().join('');
};
