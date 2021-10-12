draw_set_font(fnt_debug);
var _y = y-20;

_y += 20; draw_text(x, _y, string(gms23_simple_give_me_five()));
_y += 20; draw_text(x, _y, gms23_simple_give_me_five_as_string());

buffer_seek(bid, buffer_seek_start, 0);
buffer_write(bid, buffer_u8, 5);
buffer_write(bid, buffer_string, "five ");
_y += 20; draw_text(x, _y, gms23_simple_give_me_five_from_buffer(buffer_get_address(bid)));
