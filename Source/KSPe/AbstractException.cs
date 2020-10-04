﻿/*
	This file is part of KSPe, a component for KSP API Extensions/L
	unless when specified otherwise below this code is:

	(C) 2018-20 Lisias T : http://lisias.net <support@lisias.net>

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
namespace KSPe.Util
{
	public abstract class AbstractException : Exception
	{
		private readonly object[] parms;

		protected AbstractException(string message, params object[] @params):base(message)
		{
			this.parms = @params;
		}

		public override string Message => this.ToString();

		public virtual string ToShortMessage()
		{
			return this.ToString();
		}

		public virtual string ToLongMessage()
		{
			return this.ToString();
		}

		public override string ToString()
		{
			return string.Format(base.Message,  this.parms);
		}
	}
}