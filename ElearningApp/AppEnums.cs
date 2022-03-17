namespace ElearningApp
{
    internal class AppEnums
    {
        public class Result<T, E>
        {
            public T Ok { get; set; }

            public E Err { get; set; }

            public bool IsOk
            {
                get
                {
                    return Ok != null;
                }
            }

            public bool IsErr
            {
                get
                {
                    return Err != null;
                }
            }

            public T unwarp()
            {
                return Ok;
            }

        }
    }
}
