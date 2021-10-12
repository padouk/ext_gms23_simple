//Generated File
give_me_five = function (five) { return ccall('give_me_five', 'number', ['number'], [five]); }
give_me_five_as_string = function (five) { return ccall('give_me_five_as_string', 'string', ['string'], [five]); }
give_me_five_from_buffer = function (buffer) { return ccall('give_me_five_from_buffer', 'string', ['array'], [new Int8Array(buffer)]); }
