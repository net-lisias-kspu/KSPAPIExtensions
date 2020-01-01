﻿/*
	This file is part of KSPe, a component for KSP API Extensions/L
	(C) 2018-19 Lisias T : http://lisias.net <support@lisias.net>

	KSPe API Extensions/L is double licensed, as follows:

	* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
	* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	KSPe API Extensions/L is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with KSPe API Extensions/L. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with KSPe API Extensions/L. If not, see <https://www.gnu.org/licenses/>.

*/
using System;
using SIO = System.IO;

namespace KSPe.IO.Data
{
	// TODO: Eliminate on Vesion 3
	[System.Obsolete("KSPe.IO.Data.StreamWriter is deprecated, please use KSPe.IO.Data<T>.StreamWriter instead.")]
	public class StreamWriter : SIO.StreamWriter
	{
		internal StreamWriter(string path) : base(path) {}

		public static StreamWriter CreateForType<T>(string filename)
		{
			string path = File<T>.Data.FullPathName(true, filename);
			return new StreamWriter(path);
		}

		public static StreamWriter CreateForType<T>(string fn, params string[] fns)
		{
			string path = File<T>.Data.FullPathName(true, fn, fns);
			return new StreamWriter(path);
		}
	}
}
