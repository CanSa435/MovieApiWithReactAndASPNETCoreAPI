
import { FaDatabase } from "react-icons/fa";
import { useLocation } from "react-router-dom";

const Navbar = () => {
    const location :any = useLocation();
    const href :any = location == "/";
    const links = [
        {
            id:1,
            name:'Oyuncular',
            href:'/actors'
        },
        {
            id:2,
            name : 'Filmler',
            href : '/movies'
        },
        {
            id:3,
            name : 'Yönetmenler',
            href : '/directors'
        }
    ];
    return (
        <div className="container mx-auto">
            <div className={`flex flex-col md:flex-row items-center justify-between ${href ? 'text-white font-bold' : 'bg-blue-400 shadow-2xl text-white font-bold px-25 py-0 w-full'}`}>
                <div className='flex m-5 gap-5 text-2xl'>
                    <span>MovieApi</span> <FaDatabase className="m-1"/>
                </div>
                <ul className="flex flex-col md:flex-row items-center justify-between">
                    {
                        links.map((items:any) => (
                            <li key={items.id} className="ml-4">
                                <a className="text-white text-[20px] font-sans" href={items.href}>
                                    {items.name}
                                </a>
                            </li>
                        ))
                    }
                </ul>
            </div>

        </div>
  )
}

export default Navbar