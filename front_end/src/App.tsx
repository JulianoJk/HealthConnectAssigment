import {
  QueryClient,
  QueryClientProvider,
} from '@tanstack/react-query'
import PatientsComponent from './components/PatientsComponent';


export default function App() {
  const queryClient = new QueryClient()

  return (
    <QueryClientProvider client={queryClient}>
      <PatientsComponent />
    </QueryClientProvider>
  )
}
