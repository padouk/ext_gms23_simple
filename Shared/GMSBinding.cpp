#include "GMSBinding.h"
#include <cstdint>
#include <string>

EXTERN double give_me_five(double five = 5.0) {
    return five;
}

EXTERN const char* give_me_five_as_string(const char* five = "five") {
    return five;
}

struct interop_struct_t {
    uint8_t repeat;
    const char str[50];
};
EXTERN const char* give_me_five_from_buffer(void* buffer) {
    const interop_struct_t* pInteropOp = reinterpret_cast<interop_struct_t*>(buffer);

    std::string someStringBuilder;
    for (int i = 0; i < pInteropOp->repeat; ++i) {
        someStringBuilder += pInteropOp->str;
    }

    return someStringBuilder.c_str();
}

