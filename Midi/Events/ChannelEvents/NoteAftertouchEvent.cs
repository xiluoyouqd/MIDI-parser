/*
Copyright (c) 2013 Christoph Fabritz

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

namespace Midi.Events.ChannelEvents
{
	public class NoteAftertouchEvent : ChannelEvent
	{
		public readonly byte note_number;
		public readonly byte aftertouch_value;

		public NoteAftertouchEvent (int delta_time, byte midi_channel, byte note_number, byte aftertouch_value) : base (delta_time, 0xA0, midi_channel)
		{
			this.note_number = note_number;
			this.aftertouch_value = aftertouch_value;
		}
		
		public override string ToString ()
		{
			return "NoteAftertouchEvent(" + base.ToString () + ", note_number: " + note_number + ", aftertouch_value: " + aftertouch_value + ")";
		}
	}
}

