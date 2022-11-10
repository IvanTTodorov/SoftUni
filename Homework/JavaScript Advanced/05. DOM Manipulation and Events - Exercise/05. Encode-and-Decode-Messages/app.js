function encodeAndDecodeMessages() {
    let textAreas = Array.from(document.querySelectorAll('textarea'));
    let buttons = document.getElementsByTagName("button");



    buttons[0].addEventListener('click', encode);
    buttons[1].addEventListener('click', decode);

    function encode(e) {
        let encodedMessege = '';
        let input = textAreas[0].value;

        for (let i = 0; i < input.length; i++) {
            encodedMessege += String.fromCharCode(input[i].charCodeAt(0) + 1)
        }
        textAreas[1].value = encodedMessege;
        textAreas[0].value = '';
    }

    function decode(e) {
        let input = textAreas[1].value;
        let decodedMessege = '';
        for (let i = 0; i < input.length; i++) {
            decodedMessege += String.fromCharCode(input[i].charCodeAt(0) - 1)
        }
        textAreas[1].value = decodedMessege;
    }

}

