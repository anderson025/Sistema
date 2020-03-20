using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sistema.Entidades
{
    class CriptografaSenha
    {
        public String criptografaSHA512(string valor)
        {
            var _stringHash = "";

            try
            {
                UnicodeEncoding _encode = new UnicodeEncoding();
                byte[] _hasBytes, _messageBytes = _encode.GetBytes(valor);

                SHA512Managed _sha512Managed = new SHA512Managed();

                _hasBytes = _sha512Managed.ComputeHash(_messageBytes);

                foreach (byte item in _hasBytes)
                {
                    _stringHash += String.Format("{0:x2}", item);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return _stringHash;

        }
    }
}
