using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfExposed
    {
        public ulong nbytes { get; set; }
        //char
        public byte customized { get; set; }
        //char
        public byte n_exp_cols { get; set; }
        //char
        public byte n_exp_consts { get; set; }
        //char
        public byte n_orig_wp { get; set; }
        public ushort[] exp_cols_indices { get; set; }
        public ushort[] exp_consts_indices { get; set; }
        public ushort[] workpoints { get; set; }
        //char[16]
        public byte[] exp_md5 { get; set; }

        public PwfExposed()
        {
        }

        public PwfExposed(ulong nbytes, byte customized, byte n_exp_cols, byte n_exp_consts, byte n_orig_wp, ushort[] exp_cols_indices, ushort[] exp_consts_indices, ushort[] workpoints, byte[] exp_md5)
        {
            this.nbytes = nbytes;
            this.customized = customized;
            this.n_exp_cols = n_exp_cols;
            this.n_exp_consts = n_exp_consts;
            this.n_orig_wp = n_orig_wp;
            this.exp_cols_indices = exp_cols_indices;
            this.exp_consts_indices = exp_consts_indices;
            this.workpoints = workpoints;
            this.exp_md5 = exp_md5;
        }
    }
}
